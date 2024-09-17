import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteLinkCategoryComponent } from './delete-link-category.component';

describe('DeleteLinkCategoryComponent', () => {
  let component: DeleteLinkCategoryComponent;
  let fixture: ComponentFixture<DeleteLinkCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteLinkCategoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteLinkCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
