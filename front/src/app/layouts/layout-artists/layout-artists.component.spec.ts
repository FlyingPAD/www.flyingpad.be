import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutArtistsComponent } from './layout-artists.component';

describe('LayoutArtistsComponent', () => {
  let component: LayoutArtistsComponent;
  let fixture: ComponentFixture<LayoutArtistsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LayoutArtistsComponent]
    });
    fixture = TestBed.createComponent(LayoutArtistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
