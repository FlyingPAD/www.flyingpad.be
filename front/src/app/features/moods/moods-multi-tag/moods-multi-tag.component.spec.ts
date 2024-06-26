import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodsMultiTagComponent } from './moods-multi-tag.component';

describe('MoodsMultiTagComponent', () => {
  let component: MoodsMultiTagComponent;
  let fixture: ComponentFixture<MoodsMultiTagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodsMultiTagComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodsMultiTagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
