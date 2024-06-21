import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinkCategoriesListComponent } from './link-categories-list.component';

describe('LinkCategoriesListComponent', () => {
  let component: LinkCategoriesListComponent;
  let fixture: ComponentFixture<LinkCategoriesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LinkCategoriesListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LinkCategoriesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
